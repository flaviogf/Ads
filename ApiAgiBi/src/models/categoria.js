//dependencias
const connection = require('../config/connection');

class Categoria {
    find() {
        return connection()
            .then(Db => Db.collection('categoria'))
            .then(collection => collection.find().toArray())
            .then(documentos => {
                if(documentos.length > 0)
                    return documentos
                
                return 'nenhuma categoria encontrada';
            })
            .catch(() => 'erro');
    }
}

module.exports = Categoria;
