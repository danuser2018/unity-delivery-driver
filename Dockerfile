FROM nginx:alpine

WORKDIR /webgl
COPY build/ .

WORKDIR /etc/nginx/templates
COPY deployment/webgl.conf.template webgl.conf.template

WORKDIR /etc/nginx/conf.d
RUN rm default.conf
