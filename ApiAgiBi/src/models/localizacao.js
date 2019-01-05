//dependencias
const connection = require('../config/connection');

class Localizacao {
    find() {
        return connection()
            .then(Db => Db.collection('localizacao'))
            .then(collection => collection.find().toArray())
            .then(documentos => {
                if(documentos.length > 0)
                    return documentos;

                return 'nenhuma localização encontrada';
            })
            .catch(() => 'erro');
    }
}

module.exports = Localizacao;
