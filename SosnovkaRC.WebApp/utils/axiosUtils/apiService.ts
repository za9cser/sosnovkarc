import axiosActions, { Response } from "./axiosActions";

interface ApiService {
    get: <T>(url: string) => Promise<Response<T>>;
    post: <T, V>(url: string, body: T) => Promise<Response<V>>;
    put: <T, V>(url: string, body: T) => Promise<Response<V>>;
    patch: <T, V>(url: string, body: T) => Promise<Response<V>>;
    delete: <T>(url: string) => Promise<Response<T>>;
}

const getUrl = (url: string) => {
    const fullUrl = new URL(url, process.env.REACT_APP_API_URL!!);
    return fullUrl.href;
};

const get = <T>(url: string) => axiosActions.get<T>(getUrl(url));
const post = <T, V>(url: string, body: T) => axiosActions.post<T, V>(getUrl(url), body);
const put = <T, V>(url: string, body: T) => axiosActions.put<T, V>(getUrl(url), body);
const patch = <T, V>(url: string, body: T) => axiosActions.patch<T, V>(getUrl(url), body);
const deleteRequest = <T>(url: string) => axiosActions.delete<T>(getUrl(url));

const apiService: ApiService = { get: get, post: post, put: put, patch: patch, delete: deleteRequest };

export default apiService;
