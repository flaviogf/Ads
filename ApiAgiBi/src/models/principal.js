//dependencias
const connection = require('../config/connection');
const fs = require('fs');

class Principal {
    constructor() {
        this.arquivo = Math.floor((Math.random() * 7) + 1);
        this.categoria = Math.floor((Math.random() * 4) + 1);
        this.localizacao = Math.floor((Math.random() * 7) + 1);
        this.periodo = Math.floor((Math.random() * 4) + 1);
        this.sexo = Math.floor((Math.random() * 2) + 1);
        this.data = Date.now();
    }

    find(pular) {
        return connection()
            .then(Db => Db.collection('principal'))
            .then(collection => collection.find().limit(10).skip(pular).sort('data', -1).toArray())
            .then(documentos => {
                if(documentos.length > 0)
                    return documentos

                return 'nenhum documento encontrado';
            })
            .catch(() => 'erro');
    }

    gerarTxt() {
        connection()
            .then(Db => Db.collection('principal'))
            .then(collection => collection.find().sort('data', -1).toArray())
            .then(documentos => {
                let data = ['arquivo categoria localizacao periodo sexo \r\n'];

                if(documentos.length > 0) {
                    data = data.concat(documentos.map(documento => (
                        `${documento.arquivo} ${documento.categoria} ${documento.localizacao} ${documento.periodo} ${documento.sexo} \r\n`
                    )));
                }

                fs.writeFile('src/public/tabela.txt', data.join(''), err => {
                    if(err)
                        console.log('erro ao criar o arquivo txt');

                    console.log('txt criado com sucesso');
                });
            })
            .catch(() => console.log('erro'));
    }

    insert() {
        return connection()
            .then(Db => Db.collection('principal'))
            .then(collection => collection.insert(this))
            .then(result => {
                if(result.insertedCount > 0)
                    return 'documento inserido com sucesso';

                return 'nenhum documento inserido';
            })
            .catch(() => 'erro');
    }
}

module.exports = Principal;
