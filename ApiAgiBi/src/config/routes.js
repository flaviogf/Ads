//rotas
const ArquivoRotas = require('../routes/arquivo');
const CategoriaRotas = require('../routes/categoria');
const LocalizacaoRotas = require('../routes/localizacao');
const PeriodoRotas = require('../routes/periodo');
const PrincipalRotas = require('../routes/principal');
const SexoRotas = require('../routes/sexo');

const routes = app => {
    app.use('/arquivo', ArquivoRotas);
    app.use('/categoria', CategoriaRotas);
    app.use('/localizacao', LocalizacaoRotas);
    app.use('/periodo', PeriodoRotas);
    app.use('/principal', PrincipalRotas);
    app.use('/sexo', SexoRotas);
};

module.exports = routes;
