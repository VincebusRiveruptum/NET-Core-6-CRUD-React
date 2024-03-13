import axios from 'axios';

const API_URL = "https://localhost:7111"; // HARDCODING NO GOOD

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