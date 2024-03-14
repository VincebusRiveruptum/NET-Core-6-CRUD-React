import React from "react";
// Sections
import TopNavbar from "../UI/Nav/TopNavbar";
import BankList from "../UI/Sections/BankList";
import Footer from "../UI/Sections/Footer"
import AboutSection from "../UI/Sections/AboutSection"

import { Routes, Route, Outlet, Link } from "react-router-dom";

export default function Landing() {
  return (
    <>
      <TopNavbar />
      <Routes>
        <Route path="*" element={<BankList/>}></Route>
        <Route path="home" element={<BankList/>}></Route>
        <Route path="about" element={<AboutSection/>}></Route>
      </Routes>
      <Footer />
    </>
  );
}
  

