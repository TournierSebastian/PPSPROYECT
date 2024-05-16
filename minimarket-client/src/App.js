import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Home from "./components/Home/home";
import Signin from "./components/Login/SignIn/SignIn";
import SignupUser from "./components/Login/SingUp/SignUpUser";
import Cart from "./components/Cart/Cart";
import './App.css'
import User from "./components/User/User";
const App = () => {
  const router = createBrowserRouter([
    {
      path: "signin",
      element: <Signin />,
    },
    {
      path: "/",
      element: <Home />,
    },
    {
      path: "/signupUser",
      element: <SignupUser />,
    },
    {
      path: "/cart",
      element: <Cart></Cart>,
    },
    {
      path: "/user",
      element: <User/>
    }
  ]);
  return (
    <div className="app">
      <RouterProvider router={router}></RouterProvider>
    </div>
  );
};

export default App;
