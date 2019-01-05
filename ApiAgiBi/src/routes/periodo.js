//dependencias
const Router = require('express').Router;

//controller
const { get } = require('../controllers/periodo');

//declarações
const router = Router();

router.get('/', get);

module.exports = router;
