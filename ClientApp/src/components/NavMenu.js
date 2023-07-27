import React, { useState } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { AppRoutes } from "../AppRoutes";
import './NavMenu.css';

const NavMenu = () => {

  const [collapsed, setCollapsed] = useState(true);

  const toggleNavbar = (e) => {
    setCollapsed(!collapsed)
  }


  return (
    <header>
      <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" container light>
        <NavbarBrand tag={Link} to="/">Cadeteria</NavbarBrand>
        <NavbarToggler onClick={toggleNavbar} className="mr-2" />
        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!collapsed} navbar>
          <ul className="navbar-nav flex-grow">
            {AppRoutes.map((route, index) => {
              const { path, ...rest } = route;
              if (rest.invisible) return null;
              else {
                return (
                  <NavItem key={rest.name + index}>
                    <NavLink tag={Link} className="text-dark" to={path}>{rest.name}</NavLink>
                  </NavItem>
                )
              }
            })}
          </ul>
        </Collapse>
      </Navbar>
    </header>
  );

}

export default NavMenu;
