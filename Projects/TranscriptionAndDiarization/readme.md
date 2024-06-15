## The notebooks in this folder demonstrate the use of local AI to transcribe, diarize, and enrich transcripts created from videos

It uses:
- [pytube](https://pytube.io/en/latest/index.html)
- [moviepy](https://pypi.org/project/moviepy/)
- [transformers](https://github.com/huggingface/transformers)
- [pyannote](https://pypi.org/project/pyannote.audio/)
- [onnx-directml](https://pypi.org/project/onnxruntime-genai-directml/)

You will need to download and install microsoft/Phi-3-medium-4k-instruct-onnx-directml and update the model_path below. If you do not have GPU or are not using Windows, see the Phi-3 docs and set yourself up accordingly.

Pyannote.audio is gated on huggingface and requires an account and access key. See https://huggingface.co/pyannote/speaker-diarization-3.1 for instructions.