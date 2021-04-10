import React from "react";
import ReactDOM from "react-dom";
import { createBrowserHistory } from "history";
import { Router, Route, Switch } from "react-router-dom";

import "assets/scss/material-kit-react.scss?v=1.9.0";

// pages for this product
import Components from "views/Components/Components";
import ProfilePage from "views/ProfilePage/ProfilePage.js";

var hist = createBrowserHistory();

 const Pokedex = () =>{

   return(
    <Router history={hist}>
      <Switch>
        <Route path="/profile-page" component={ProfilePage} />
        <Route path="/"component={Components} />
        <Route path="/editar/:id"
            render={props => {
              const idPokemon = parseInt(props.match.params.id);
              return (
                <ProfilePage 
                  id={idPokemon}
                  operacion = "put"
                />
              )
          }} />
        <Route path="/ver/:id" 
                render={props => {
                  const idPokemon = parseInt(props.match.params.id);
                  return (
                    <ProfilePage 
                      id={idPokemon}
                      operacion = "Get"
                    />
                  )
          }} />
      </Switch>
    </Router>
   );
 }

ReactDOM.render(<Pokedex />,document.getElementById("root")
);
