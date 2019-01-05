//dependencias
const Localizacao = require('../models/localizacao');

const get = (req, res) => {
    const obj = new Localizacao();

    obj.find()
        .then(resultado => res.send(resultado));
};

module.exports = { get };
