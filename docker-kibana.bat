docker run -d -p 5601:5601 -h kibana --name kibana --link elasticsearch:elasticsearch kibana
pause
start http://10.0.75.1:5601

