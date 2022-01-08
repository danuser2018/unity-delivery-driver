FROM nginx:alpine

WORKDIR /webgl
COPY build/ .

WORKDIR /etc/nginx/conf.d
RUN rm default.conf
COPY deployment/webgl.conf webgl.conf