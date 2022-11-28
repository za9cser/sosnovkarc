import axios, { AxiosRequestConfig } from "axios";

type Response<T> = {
    isOk: boolean;
    data: T | null;
    error: any;
};

export type { Response };

interface AxiosActions {
    getAsync: <T>(url: string) => Promise<Response<T>>;
    postAsync: <T, V>(url: string, body: T) => Promise<Response<V>>;
}

const CONFIG: AxiosRequestConfig = {
    responseType: "json",
    headers: {
        "Content-Type": "application/json",
        Accept: "application/json",
    },
};

const getAsync = async <T>(url: string) => {
    try {
        const response = await axios.get<T>(url, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const postAsync = async <T, V>(url: string, body: T) => {
    try {
        const response = await axios.post<V>(url, body, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const axiosActions: AxiosActions = { getAsync, postAsync };

export default axiosActions;
