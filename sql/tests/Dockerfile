FROM node:14.7.0-alpine3.12

WORKDIR /app

COPY package.json .

RUN npm install

COPY . .

ENTRYPOINT ["/app/entrypoint.sh"]