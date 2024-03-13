import React from 'react';
import styled from "styled-components";
import FullButton from '../Buttons/FullButton';
import { useSelector, useDispatch } from 'react-redux';
import { getByID, getByGUID } from '../../../store/bankSlice'; // Import your action creators

export default function SearchBankMenu({dispatch}) {
    
    const handleSearchSubmit = (event) => {
        event.preventDefault();

        const searchType = document.getElementById('searchBy').value;
        const idSearch = document.getElementById('searchInput').value;

        if (searchType === 'byId') {
            //Call store to show element by Id
            console.log("You are searching by ID:" + idSearch);
            dispatch(getByID(idSearch));

        } else {
            //Call store to show element by GUID
            console.log("You are searching by GUID:" + idSearch);
            dispatch(getByGUID(idSearch));
        }
    }
    return (
        <Wrapper className="container">
            <FormBox>
                <BankForm onSubmit={handleSearchSubmit}>
                    <DropdownBox>
                        <label htmlFor="searchBy">Search</label>
                        <select name="searchBy" id="searchBy">
                            <option value="byId">By ID</option>
                            <option value="byGuid">By GUID</option>
                        </select>
                    </DropdownBox>
                    <InputsBox>
                        <label htmlFor="searchInput"></label>
                        <input type="text" id="searchInput" name="searchInput" required></input>
                    </InputsBox>
                    <ButtonBox>
                        <FullButton color="#606060" title="Search"></FullButton>
                    </ButtonBox>
                </BankForm>

            </FormBox>
            <hr></hr>
        </Wrapper>
    );
}

const Wrapper = styled.section`
  padding-top:5%;
`;

const FormBox = styled.div`
  display:flex;
  justify-content:center;
  padding:5%;
`;

const DropdownBox = styled.div`
padding:2%;
display:flex;
flex-direction:row;
  label{
      margin:auto;
      padding-right:5%;
  }
`;
const InputsBox = styled.div`
padding:2%;
display:flex;
flex-direction:row;
    padding:2%;
`;

const ButtonBox = styled.div`
padding:2%;
display:flex;
flex-direction:row;
    padding:2%;
`;


const BankForm = styled.form`
  display: flex;

  justify-content: center;

`;

