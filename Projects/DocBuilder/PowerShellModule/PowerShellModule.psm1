$scriptdir = $PSScriptRoot
[Reflection.Assembly]::LoadFrom("$scriptdir\assemblies\netstandard2.0\DocBuilder.dll")
[Reflection.Assembly]::LoadFrom("$scriptdir\assemblies\net48\PowerPointTools.dll")

$baseReposFolder = Convert-Path -Path $scriptdir\..\..\..

Write-Host "Hey! Doc Builder module loaded. Base Repos Folder is " $baseReposFolder
Write-Host "If this is not correct, you can change it with Set-DocGenerationBaseReposFolder"

<#
.SYNOPSIS
    Sets the base repositories folder path for the documentation generation.

.DESCRIPTION
    The Set-DocGenerationBaseReposFolder function sets the base repositories folder path to be used for documentation generation.

.PARAMETER BaseReposFolder
    Specifies the path to the base repositories folder.

.EXAMPLE
    Set-DocGenerationBaseReposFolder -BaseReposFolder "C:\Users\user\Documents\BaseRepos"

    This example sets the base repositories folder path to "C:\Users\user\Documents\BaseRepos".
#>
function Set-DocGenerationBaseReposFolder {
    param
	(
        [Parameter()]
		[string]$BaseReposFolder
	)

    $baseReposFolder = $BaseReposFolder
}

<#
.SYNOPSIS
    Converts a PowerPoint presentation to Markdown format.

.DESCRIPTION
    The Convert-PowerPointToMarkdown function converts a PowerPoint presentation to Markdown format, with images extracted to a specified folder.

.PARAMETER PptFilePath
    Specifies the path to the PowerPoint presentation file to be converted.

.PARAMETER MarkdownFolder
    Specifies the output folder path for the generated Markdown files.

.PARAMETER ImageFolder
    Specifies the output folder path for the extracted images.

.PARAMETER MarkdownFileName
    Specifies the name of the output Markdown file.

.EXAMPLE
    Convert-PowerPointToMarkdown -PptFilePath "C:\Users\user\Documents\presentation.pptx" -MarkdownFolder "C:\Users\user\Documents\Markdown" -ImageFolder "C:\Users\user\Documents\Images" -MarkdownFileName "presentation.md"

    This example converts the "presentation.pptx" file to a Markdown file named "presentation.md" and saves it in the "C:\Users\user\Documents\Markdown" folder. Images are extracted and saved to the "C:\Users\user\Documents\Images" folder.
#>
function Convert-PowerPointToMarkdown {
    param
	(
        [Parameter()]
		[string]$PptFilePath,

        [Parameter()]
		[string]$MarkdownFolder,

        [Parameter()]
		[string]$ImageFolder,

        [Parameter()]
		[string]$MarkdownFileName
	)

    $Error.Clear()

    $converter = [PowerPointTools.Converters.PowerPointToMarkdown]::new($PptFilePath, $MarkdownFolder, $ImageFolder) 
    $converter.ConvertToMarkdown($MarkdownFileName)
}

<#
.SYNOPSIS
    Generates Markdown documentation for PowerShell scripts in a specified folder.

.DESCRIPTION
    The New-PowerShellDocumentation function generates Markdown documentation for PowerShell scripts in a specified folder and outputs the documentation to the specified output directory.

.PARAMETER ScriptFolder
    Specifies the folder containing the PowerShell scripts to be documented.

.PARAMETER OutputDir
    Specifies the output directory for the generated Markdown documentation.

.PARAMETER IncludeTOC
    Indicates whether to include a Table of Contents (TOC) in the documentation. By default, this parameter is set to false.

.PARAMETER IndexHeader
    Specifies the header text for the index page of the documentation.

.PARAMETER IndexHeaderDesciption
    Specifies the description text for the index page of the documentation.

.EXAMPLE
    New-PowerShellDocumentation -ScriptFolder "C:\Users\user\Documents\Scripts" -OutputDir "C:\Users\user\Documents\Documentation" -IncludeTOC $true -IndexHeader "My PowerShell Scripts" -IndexHeaderDesciption "A collection of PowerShell scripts."

    This example generates documentation for PowerShell scripts in the "C:\Users\user\Documents\Scripts" folder and saves the documentation in the "C:\Users\user\Documents\Documentation" folder. A Table of Contents is included, and the index page header and description are set accordingly.
#>
function New-PowerShellDocumentation{
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true)]
        [string]$ScriptFolder,

        [Parameter(Mandatory = $true)]
        [string]$OutputDir,

        [Parameter(Mandatory = $false)]
        [bool]$IncludeTOC = $false,

        [Parameter(Mandatory = $true)]
        [string]$IndexHeader = "",

        [Parameter(Mandatory = $true)]
        [string]$IndexHeaderDesciption = ""
    )

    begin{
        $Error.Clear()
        # Get the scripts from the folder
        $scripts = Get-Childitem $ScriptFolder -Filter "*.ps1" -Recurse
        $arrParameterProperties = @("DefaultValue", "ParameterValue", "PipelineInput", "Position", "Required")
        $scriptNameSuffix = ".md"
        
        $commandReference = @{}

        if (!(Test-Path $OutputDir)) {
            Write-Information ("Output path does not exists creating the folder: $($OutputDir)")
            New-Item -ItemType Directory -Force -Path $OutputDir
        }

        if($IncludeTOC)
        {
            $tocFile = "$OutputDir\toc.yml"
            Out-File -FilePath $tocFile
            "- name: Command Reference" | Out-File -FilePath $tocFile -Append
            "  href: index$scriptNameSuffix" | Out-File -FilePath $tocFile -Append
        }
    }

    process{
        try {
            foreach ($script in $scripts) {
                Write-Host ("Documenting file: $($script.FullName)")

                $outputFile = "$OutputDir\$($script.BaseName)$scriptNameSuffix"
                Out-File -FilePath $outputFile
            
                $help = Get-Help $script.BaseName -ErrorAction "SilentlyContinue" -Detailed

                if($IncludeTOC)
                {
                    "- name: $($script.BaseName)" | Out-File -FilePath $tocFile -Append
                    "  href: $($script.BaseName)$scriptNameSuffix" | Out-File -FilePath $tocFile -Append
                }
                
                if($help)
                {
                    #header
                    if($script.BaseName){
                        ("# $($script.BaseName)") | Out-File -FilePath $outputFile -Append
                        "`n" | Out-File -FilePath $outputFile -Append
                    }
            
                    #synopsis
                    if ($help.Synopsis) {
                        ("## Synopsis") | Out-File -FilePath $outputFile -Append
                        ("$($help.Synopsis)") | Out-File -FilePath $outputFile -Append
                        "`n" | Out-File -FilePath $outputFile -Append
                        $commandReference.Add("[$($script.BaseName)]($($script.BaseName)$scriptNameSuffix)",$help.Synopsis)
                    } else {
                        Write-Warning -Message ("Synopsis not defined in file $($script.fullname)")
                    }
            
                    #syntax
                    if ($help.Syntax) {
                        ("``````PowerShell`n") | Out-File -FilePath $outputFile -Append
                        $parameterSyntax=""
                        foreach ($param in $help.Syntax.syntaxItem.parameter) {
                            if($param.parameterValue){
                                $parameterSyntax += "[-$($param.name)] <$($param.parameterValue)> "
                            }else{
                                $parameterSyntax += "[-$($param.name)] "
                            }
                        }
                        $parameterSyntax += "[<CommonParameters>]"
            
                        ("$($script.BaseName) $parameterSyntax")| Out-File -FilePath $outputFile -Append
                        
                        "`n``````" | Out-File -FilePath $outputFile -Append
                        "`n" | Out-File -FilePath $outputFile -Append
                    } else {
                        Write-Warning -Message ("Syntax not defined in file $($script.fullname)")
                    }
            
                    #notes (seperated by (name): and (value);)
                    if ($help.alertSet) {
                        ("## Information") | Out-File -FilePath $outputFile -Append
                        $text = $help.alertSet.alert.Text.Split(';', $option)
                        foreach ($line in $text) {
                            $items = $line.Trim().Split(':', $option)
                            ("**$($items[0]):** $($items[1])`n") | Out-File -FilePath $outputFile -Append
                        }
                        "`n" | Out-File -FilePath $outputFile -Append
                    } else {
                        Write-Warning -Message ("Notes not defined in file $($script.fullname)")
                    }
            
                    #description
                    if ($help.Description) {
                        "## Description" | Out-File -FilePath $outputFile -Append
                        $help.Description.Text | Out-File -FilePath $outputFile -Append
                        "`n" | Out-File -FilePath $outputFile -Append
                    } else {
                        Write-Warning -Message "Description not defined in file $($script.fullname)"
                    }
            
                    #examples
                    if ($help.Examples) {
                        ("## Examples") | Out-File -FilePath $outputFile -Append
                        "`n" | Out-File -FilePath $outputFile -Append
                        forEach ($item in $help.Examples.Example) {
                            $title = $item.title.Replace("--------------------------", "").Replace("EXAMPLE", "Example")
                            ("### $($title)") | Out-File -FilePath $outputFile -Append
                            ("$($item.remarks.Text)") | Out-File -FilePath $outputFile -Append
            
                            if ($item.Code) {
                                ("``````PowerShell`r`n $($item.Code) `r`n``````") | Out-File -FilePath $outputFile -Append
                            }
                        }
                    } else {
                        Write-Warning -Message "Examples not defined in file $($script.fullname)"
                    }
            
                    if ($help.Parameters) {
                        ("## Parameters") | Out-File -FilePath $outputFile -Append
                        forEach ($item in $help.Parameters.Parameter) {
                            ("### $($item.name)") | Out-File -FilePath $outputFile -Append
                            if($item.description.length -gt 0)
                            {
                                $item.description[0].text | Out-File -FilePath $outputFile -Append
                            }
                            
                            ("| Member | Value |") | Out-File -FilePath $outputFile -Append
                            ("|-|-|") | Out-File -FilePath $outputFile -Append
                            ("| Type: | $($item.Type.Name) |") | Out-File -FilePath $outputFile -Append
                            foreach ($arrParameterProperty in $arrParameterProperties) {
                                if ($item.$arrParameterProperty) {
                                    ("| $arrParameterProperty : | $($item.$arrParameterProperty)|") | Out-File -FilePath $outputFile -Append
                                }
                            }
                            "`n" | Out-File -FilePath $outputFile -Append
                        }
                    } else {
                        Write-Warning -Message "Parameters not defined in file $($script.fullname)"
                    }
                }else {
                    Write-Error -Message ("Synopsis could not be found for script $($script.FullName)")
                }
                
            }
        }
        catch {
            Write-Error "Something went wrong while generating the output documentation: $_"
        }
    }

    end{
        $outputFile = "$OutputDir\index$scriptNameSuffix"
        Out-File -FilePath $outputFile
        ("# $IndexHeader") | Out-File -FilePath $outputFile -Append
        "`n" | Out-File -FilePath $outputFile -Append

        ("$IndexHeaderDesciption `n") | Out-File -FilePath $outputFile -Append
        "<br/>`n" | Out-File -FilePath $outputFile -Append

        ("| Command | Description |") | Out-File -FilePath $outputFile -Append
        ("|-|-|") | Out-File -FilePath $outputFile -Append
        $commandReference.keys | ForEach-Object{
            ("|$($_)|$($commandReference[$_])|") | Out-File -FilePath $outputFile -Append
        }
    }
}

<#
.SYNOPSIS
    Builds a documentation website using DocFx.

.DESCRIPTION
    The Invoke-DoxFxBuild function builds a documentation website using DocFx, based on the specified parameters.

.PARAMETER WorkingFolder
    Specifies the working folder path for the DocFx build process.

.PARAMETER OutputFolder
    Specifies the output folder
#>
function Invoke-DoxFxBuild {
	[CmdletBinding()]
	param
	(
        [Parameter()]
		[string]$WorkingFolder,

        [Parameter()]
		[string]$OutputFolder,

        [Parameter()]
		[string]$StaticContentFolder,

	    [Parameter()]
	    [string[]]$Projects,

        [Parameter()]
	    [string[]]$ProjectBasePath,
        
        [Parameter()]
	    [string[]]$ContentFiles,
        
        [Parameter()]
	    [string[]]$ResourceFiles,
        
        [Parameter()]
		[switch]$EnableGitFeatures
	)

	$Error.Clear()


    $startingLocation = Get-Location
    $temp = $ENV:Temp

    Set-Location $temp

    if($null -eq $WorkingFolder -or $WorkingFolder -eq "") 
    { 
        $WorkingFolder = "working" 
    }
    if($null -eq $OutputFolder -or $WorkingFolder -eq $OutputFolder)
    { 
        $OutputFolder = "_site" 
    }

    $docFxConfig = New-Object DocFxHelper.DocFxConfig

    mkdir $WorkingFolder

    Copy-Item "$baseReposFolder\DocBuilder\DocFx\*" -Destination "$temp\$WorkingFolder" -Recurse -Force -Verbose
    Copy-Item $StaticContentFolder\* -Destination "$temp\$WorkingFolder" -Recurse -Force -Verbose
    Set-Location "$temp\$WorkingFolder"

    if($Projects.length -gt 0)
    {
        $Projects | ForEach-Object { $docFxConfig.metadata[0].src.files.Add($_.Replace("\", "/")) }
        $docFxConfig.metadata[0].src.cwd = $ProjectBasePath
        $docFxConfig.metadata[0].dest = "api"
    }
    else
    {
        $docFxConfig.metadata = @()
    }

    $docFxConfig.build.content[0].files = $ContentFiles
        
    $docFxConfig.build.resource[0].files = $ResourceFiles
    $docFxConfig.build.dest = "_site"
    $docFxConfig.build.template.Add("templates/default")
    $docFxConfig.build.template.Add("templates/modern")
        
    ConvertTo-Json -InputObject $docFxConfig -Depth 4 -Compress | Out-File -FilePath ".\docfx.json"
    
    Write-Host "Wrote .\docfx.json"

    if($EnableGitFeatures -eq $true){
        Invoke-Expression "docfx"
    }
    else {
        Invoke-Expression "docfx --disableGitFeatures"
    }
        
    Copy-Item ".\_site\*" $OutputFolder -Recurse -Force
    
    Set-Location $startingLocation
    Remove-Item "$temp\$WorkingFolder" -Force -Recurse
}

<#
.SYNOPSIS
    Creates a PowerPoint presentation from JSON data using a template file.

.DESCRIPTION
    The Convert-JsonToPowerPoint cmdlet creates a PowerPoint presentation based on the provided JSON data and a PowerPoint template. The cmdlet takes the JSON file path and the output path as inputs. The template file (template.pptx) should be in the same directory as the PSM1 file.

.PARAMETER JsonFilePath
    Path to the JSON input file.

.PARAMETER Destination
    Path to save the PowerPoint presentation.

.EXAMPLE
    Convert-JsonToPowerPoint -JsonFilePath "C:\data.json" -Destination "C:\output.pptx"

    Creates a PowerPoint presentation at "C:\output.pptx" based on the JSON data from "C:\data.json" and the template file "template.pptx" in the same directory as the PSM1 file.
#>
function Convert-JsonToPowerPoint {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$true)]
        [string]$JsonFilePath,

        [Parameter(Mandatory=$true)]
        [string]$Destination
    )

    process {
        # Get the path to the template file
        $templatePath = "$scriptdir\template.pptx"

        $jsonString = Get-Content -Path $JsonFilePath -Raw
        $dictionary = New-Object 'System.Collections.Generic.Dictionary[string,string]'
        (ConvertFrom-Json $jsonString).PSObject.Properties | ForEach-Object {
            $dictionary.Add($_.Name, $_.Value)
        }

        # Create an instance of the DictionaryToPowerPoint class
        $dictionaryToPowerPoint = New-Object PowerPointTools.Converters.DictionaryToPowerPoint

        # Call the CreatePresentationFromDictionary method
        $dictionaryToPowerPoint.CreatePresentationFromDictionary($dictionary, $templatePath, $Destination)
    }
}

