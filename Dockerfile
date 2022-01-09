FROM nginx:alpine

WORKDIR /webgl
COPY build/ .

WORKDIR /etc/nginx/conf.d
RUN rm default.conf
COPY deployment/webgl.conf webgl.conf

CMD sed -i -e 's/$PORT/'"$PORT"'/g' /etc/nginx/conf.d/webgl.conf && nginx -g 'daemon off;'