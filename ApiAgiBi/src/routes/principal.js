//dependencias
const Router = require('express').Router;

//controller
const { get, post } = require('../controllers/principal');

//declarações
const routes = Router();

routes.get('/', get);
routes.get('/:pular', get);
routes.post('/', post);

module.exports = routes;
