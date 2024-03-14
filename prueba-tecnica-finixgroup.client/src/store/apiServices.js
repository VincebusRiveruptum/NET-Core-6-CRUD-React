import axios from 'axios';

const API_URL = "https://localhost:7111"; // HARDCODING NO GOOD

//GET
export const fetchBanks = async () => {
    console.log("This is the front address: " + API_URL);
    try {
        const response = await axios.get(`${API_URL}/api/Bank`);
        console.log(response.data);
        return response.data;
    } catch (error) {
        console.error('Error fetching banks:', error);
        throw error;
    }
};

// POST
export const addBank = async ({ id, uid, account_number, iban, bank_name, routing_number, swift_bic }) => {
    // Request new ID from server, add one manually or assign on controller?
    console.log("This is the front address: " + API_URL);
    try {
        const response = await axios.post(`${API_URL}/api/Bank`, {
            id: id,
            uid: uid,
            account_number: account_number,
            iban: iban,
            bank_name: bank_name,
            routing_number: routing_number,
            swift_bic: swift_bic
        });
        
        return response.data; // Assuming you want to return the data from the response
    } catch (error) {
        console.error('Error adding bank:', error);
        throw error;
    }
};


// PUT {id}
export const putByID = async ({id, uid, account_number, iban, bank_name, routing_number, swift_bic}) => {
    console.log("This is the front address: " + API_URL);
    try {
        const response = await axios.put(`${API_URL}/api/Bank/${id}`, {
            id: id,
            uid: uid,
            account_number: account_number,
            iban: iban,
            bank_name: bank_name,
            routing_number: routing_number,
            swift_bic: swift_bic
        });
        
        return response.data; // Assuming you want to return the data from the response
    } catch (error) {
        console.error(`Error modifying entry ${id}: ${error}`);
        throw error;
    }
}

// GET {id}
export const getByID = async (id) => {
    console.log("This is the front address: " + API_URL);
    try {
        const response = await axios.get(`${API_URL}/api/Bank/${id}`);
        console.log(response.data); // Logging response data
        return response.data; // Returning response data
    } catch (error) {
        console.error(`Error fetching bank with id: ${id}: ${error}`);
        throw error;
    }
}

// DELETE {id}

export const deleteById = async (id) => {
    console.log("This is the front address: " + API_URL);
    try {
        const response = await axios.delete(`${API_URL}/api/Bank/${id}`);
        console.log(response.data); // Logging response data
        return response.data; // Returning response data
    } catch (error) {
        console.error(`Error deleting entry with id: ${id}: ${error}`);
        throw error;
    }
}

// UUID GENERATION

export const generateUUID = () => { // Public Domain/MIT
    var d = new Date().getTime();//Timestamp
    var d2 = ((typeof performance !== 'undefined') && performance.now && (performance.now()*1000)) || 0;//Time in microseconds since page-load or 0 if unsupported
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
        var r = Math.random() * 16;//random number between 0 and 16
        if(d > 0){//Use timestamp until depleted
            r = (d + r)%16 | 0;
            d = Math.floor(d/16);
        } else {//Use microseconds since page-load if supported
            r = (d2 + r)%16 | 0;
            d2 = Math.floor(d2/16);
        }
        return (c === 'x' ? r : (r & 0x3 | 0x8)).toString(16);
    });
}

