//dependencias
const Categoria = require('../models/categoria');

const get = (req, res) => {
    const obj = new Categoria();

    obj.find()
        .then(resultado => res.send(resultado));
};

module.exports = { get };
