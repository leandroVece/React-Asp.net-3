import Login from "./components/Login";
import Register from "./components/Register";
import Home from './components/Home';
import Cadete from './components/Cadete';
import Pedido from './components/Pedido';
import Cliente from './components/Cliente';
import Error from "./components/Error";
import Usuarios from "./components/User";
import TomarPedido from "./components/TomarPedido";
import ActionPedido from "./components/ActionPedido";
import FormPedido from "./components/FormPedido";
import UpdateUser from "./components/UpdateUser";

const AppRoutes = [
  {
    index: true,
    name: "Home",
    path: '/',
    private: false,
    element: <Home />
  },
  {
    name: "Cadete",
    path: '/cadete',
    private: true,
    element: <Cadete />
  },
  {
    name: "Cliente",
    path: '/cliente',
    private: true,
    element: <Cliente />
  },
  {
    name: "Pedido",
    path: '/pedido',
    element: <Pedido />
  },
  {
    name: "Login",
    path: '/login',
    private: false,
    element: <Login />
  },
  {
    name: "Register",
    path: '/register',
    publicOnly: true,
    element: <Register />
  },
  {
    invisible: true,
    path: '/formPedido',
    element: <FormPedido />
  },
  {
    invisible: true,
    path: '/tomarPedido',
    element: <TomarPedido />
  },
  {
    invisible: true,
    path: '/actionPedido',
    element: <ActionPedido />
  },
  {
    name: "Usuarios",
    path: '/Usuarios',
    private: true,
    exclusive: true,
    element: <Usuarios />
  },
  {
    path: '/UpdateUser',
    private: true,
    exclusive: true,
    invisible: true,
    element: <UpdateUser />
  },
  {
    path: '*',
    private: false,
    element: <Error />,
  }
];

export { AppRoutes };
