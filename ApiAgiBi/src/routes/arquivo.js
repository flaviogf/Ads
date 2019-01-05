//dependencias
const Router = require('express').Router;

//controller
const { get } = require('../controllers/arquivo');

//declarações
const router = Router();

router.get('/', get);

module.exports = router;
