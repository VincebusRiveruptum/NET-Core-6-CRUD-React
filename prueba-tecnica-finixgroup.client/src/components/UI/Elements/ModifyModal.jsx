import React from 'react';
import styled from 'styled-components';
import { useState } from 'react';
import {putByID} from "../../../store/apiServices";

export default function ModifyModal({ bankItem, onClose }) {
    const [responseMessage, setResponseMessage] = useState(null);

    const onModify = (e) => {
        e.preventDefault();

        let newName = document.getElementById("nameInput").value;

        if (!newName || newName.trim() === '') {
            setResponseMessage("*Name to modify is required");
            return;
        }
        let request = { id: bankItem.id, bank_name: newName };
        putByID(request)
            .then((response) => {
                console.log(response);
                // If modification is successful, trigger page refresh
                window.location.reload();
            })
            .catch((error) => {
                // Handle error if modification fails
                setResponseMessage('*Error modifying bank:', error);
            });
    };

    return (
        <ModalOverlay>
            <ModalContent>
                <h2>Modify Bank</h2>
                <p>ID: {bankItem.id}</p>
                <p>Bank Name: {bankItem.bank_name}</p>
                <ModifyInput>
                    <form id="modifyForm" onSubmit={ (e) => onModify(e)}>
                        <input className="font18" type="text" placeholder="New bank name" id="nameInput"/>
                    </form>
                </ModifyInput>
                {responseMessage && <ResponseLabel success={!responseMessage.startsWith('*')}>{responseMessage}</ResponseLabel> }
                <hr />
                <ModalFooter>
                    <Button onClick={onClose}>Close</Button>
                    <Button form="modifyForm">Modify</Button>
                </ModalFooter>
            </ModalContent>
        </ModalOverlay>
    );
}

const ModifyInput = styled.div`
    padding-top:5%;
    padding-bottom:5%;
    input{
        min-width:250px;
        text-align: center; 
    }
`;
const ModalOverlay = styled.div`
position: fixed;
top: 0;
left: 0;
width: 100%;
height: 100%;
background-color: rgba(0, 0, 0, 0.01);
display: flex;
justify-content: center;
align-items: center;
z-index: 999;
`;

const ResponseLabel = styled.p`
    color: ${({ success }) => (success ? 'green' : 'red')};
`;


const ModalContent = styled.div`
background-color: white;
padding: 20px;
border-radius: 4px;
animation: slideIn 0.3s ease-out forwards;
transform: translateY(100%);
@keyframes slideIn {
    from {
        transform: translateY(100%);
    }
    to {
        transform: translateY(0);
    }
}
`;

const ModalFooter = styled.div`
background-color: white;
text-align:center;
`;

const Button = styled.button`

margin: 10px;
padding: 8px 16px;
background-color: #505050;
color: white;
border: none;
border-radius: 4px;
cursor: pointer;
`;