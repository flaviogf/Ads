//dependencias
const Arquivo = require('../models/arquivo');

const get = (req, res) => {
    const obj = new Arquivo();

    obj.find()
        .then(resultado => res.send(resultado));
};

module.exports = { get };
