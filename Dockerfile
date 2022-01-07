FROM nginx:alpine

WORKDIR /webgl
COPY Build/ .

WORKDIR /etc/nginx/conf.d
RUN rm default.conf
COPY Deploy/webgl.conf webgl.conf