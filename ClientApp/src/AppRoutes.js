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

const AppRoutes = [
  {
    index: true,
    name: "Home",
    path: '/',
    element: <Home />
  },
  {
    name: "Cadete",
    path: '/cadete',
    element: <Cadete />
  },
  {
    name: "Cliente",
    path: '/cliente',
    element: <Cliente />
  },
  {
    name: "Pedido",
    path: '/pedido',
    element: <Pedido />
  },
  {
    name: "Usuarios",
    path: '/usuarios',
    element: <Usuarios />
  },
  {
    name: "Login",
    path: '/login',
    element: <Login />
  },
  {
    name: "Register",
    path: '/register',
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
    path: '*',
    private: false,
    element: <Error />,
  }
];

export { AppRoutes };