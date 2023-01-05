import axios, { AxiosRequestConfig } from "axios";

type Response<T> = {
    isOk: boolean;
    data: T | null;
    error: any;
};

export type { Response };

interface AxiosActions {
    get: <T>(url: string) => Promise<Response<T>>;
    post: <T, V>(url: string, body: T) => Promise<Response<V>>;
    put: <T, V>(url: string, body: T) => Promise<Response<V>>;
    patch: <T, V>(url: string, body: T) => Promise<Response<V>>;
    delete: <T>(url: string) => Promise<Response<T>>;
}

const CONFIG: AxiosRequestConfig = {
    responseType: "json",
    headers: {
        "Content-Type": "application/json",
        Accept: "application/json",
    },
};

const get = async <T>(url: string) => {
    try {
        const response = await axios.get<T>(url, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const post = async <T, V>(url: string, body: T) => {
    try {
        const response = await axios.post<V>(url, body, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const put = async <T, V>(url: string, body: T) => {
    try {
        const response = await axios.put<V>(url, body, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const patch = async <T, V>(url: string, body: T) => {
    try {
        const response = await axios.patch<V>(url, body, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const deleteRequest = async <T>(url: string) => {
    try {
        const response = await axios.delete<T>(url, CONFIG);
        return { isOk: true, data: response.data, error: null };
    } catch (error: any) {
        return { isOk: false, data: null, error: error };
    }
};

const axiosActions: AxiosActions = { get: get, post: post, put: put, patch: patch, delete: deleteRequest };

export default axiosActions;
