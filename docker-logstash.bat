docker run -d -h logstash --name logstash --link elasticsearch:elasticsearch -it --rm -v "%~dp0.":/config-dir logstash -f /config-dir/docker-logstash.conf
pause
docker attach logstash