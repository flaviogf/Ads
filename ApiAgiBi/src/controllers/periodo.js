//dependencias
const Periodo = require('../models/periodo');

const get = (req, res) => {
    const obj = new Periodo();

    obj.find()
        .then(resultado => res.send(resultado));
};

module.exports = { get };
