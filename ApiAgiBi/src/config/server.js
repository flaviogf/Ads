//dependencias
const bodyParser = require('body-parser');
const express = require('express');
const routes = require('./routes');
const cors = require('./cors');

//declarações
const app = express();
const port = process.env.PORT || 5000;

//arquivos estaticos
app.use(express.static('src/public'));

//middlewares
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());
app.use(cors);

//configuração de rotas
routes(app);

//servidor
app.listen(port, () => {
    console.log(`Servidor rodando na porta ${port}`);
});
