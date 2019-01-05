//dependencias
const Principal = require('../models/principal');

const get = (req, res) => {
    const pular = parseInt(req.query.pular) || 0;

    const obj = new Principal();

    obj.find(pular)
        .then(resultado => {
            res.send(resultado);

            obj.gerarTxt();

            res.end();
        });
};

const post = (req, res) => {
    const obj = new Principal();

    obj.insert()
        .then(resultado => res.send(resultado));
}

module.exports = { get, post };
