import React, { useState } from 'react';
import styled from "styled-components";
import FullButton from '../Buttons/FullButton';

import { fetchBanks,addBank,putByID,getByID,deleteById, generateUUID} from "../../../store/apiServices";

export default function ApiTestingControl(){

    const handleFetchBanks = () => {
        const response = fetchBanks();
        console.log(response);
    }

    const handleAddBanks = () => {
        let request = {id:123, uid: (generateUUID()), account_number:"12345", iban:"123456", bank_name:"Testing Bank Co.", routing_number:"12345678", swift_bic:"ABC"}
        let response =addBank(request);
        console.log(request);
        console.log(response);
    }

    const handlePutByID = () => {
        const response =putByID();
        console.log(response);
    }
    const handleGetByID = () => {
        const response =getByID();
        console.log(response);
    }

    const handleDeleteById = () => {
        const response =deleteById();
        console.log(response);
    }

    return (
        <Wrapper className="container">
            <Title>
                <h1 className='font30 semiBold'>API Testing tools</h1>
                <p className="font13"> From the code, you can set the request parameters directly to each method down there, by the same method name. Remember that id's are unique and the GUID is generated here on the client itself. You must check your browser's console for the request response results.</p>
            </Title>
            <TestingBox>
                <FullButton color="#ff1759" title="fetchBanks" action={() => handleFetchBanks()}></FullButton>
                <FullButton color="#ff1759" title="addBank" action={() => handleAddBanks()}></FullButton>
                <FullButton color="#ff1759" title="putByID" action={() => handlePutByID()}></FullButton> 
                <FullButton color="#ff1759" title="getByID" action={() => handleGetByID()}></FullButton>
                <FullButton color="#ff1759" title="deleteById" action={() => handleDeleteById()}></FullButton>
            </TestingBox>
        </Wrapper>
    )
}

const Wrapper = styled.section`
    display: flex;
    justify-content: center;
    flex-direction: column;
    width: 100%;
    padding: 2% 0; /* Add vertical padding */
    margin-top: 20px; /* Adjust for the maximum height of your navbar */

`;

const Title = styled.div`
  @media (max-width: 760px) {
      justify-content: center;
  }
`;

const TestingBox = styled.div`
  display: flex;
  justify-content: center;
  padding:2%;
  @media (max-width: 760px) {
      justify-content: center;
  }
`;
