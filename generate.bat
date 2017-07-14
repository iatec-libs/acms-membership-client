@echo off
rmdir /s/q docs src .vs
java -jar "generator\swagger-codegen-cli.jar" generate -l csharp -i "swagger/spec.yaml" ^
	--config "generator\config.json" --model-name-suffix=Model ^
	--additional-properties packageTitle="Iatec ACMS API Client"
