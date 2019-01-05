//dependencias
const Sexo = require('../models/sexo');

const get = (req, res) => {
    const obj = new Sexo();

    obj.find()
        .then(resultado => res.send(resultado));
};

module.exports = { get };
