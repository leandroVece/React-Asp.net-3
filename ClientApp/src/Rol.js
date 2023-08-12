const roles = [
    {
        type: 'admin',
        read: true,
        write: true,
        delete: true,
        actionCadete: true,
        actionCliente: true
    },
    {
        type: 'cadete',
        read: true,
        write: false,
        delete: false,
        actionCadete: true,
    },
    {
        type: 'cliente',
        read: true,
        write: false,
        delete: false,
        actionCliente: true
    }
]

export default roles;