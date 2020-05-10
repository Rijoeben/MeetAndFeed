import Repository from './Repository'
const qs = require('querystring')
const recource = '/api/User'

export default {
  checkCredentials (email, password) {
    const payload = email + ',' + password
    return Repository.get(`${recource}/${payload}`)
  },
  getId (email) {
    return Repository.get(`${recource}/${email}`)
  },
  getUserById (userId) {
    return Repository.get(`/login/${userId}`)
  },
  RegisterUser (firstName, lastName, adress, email, preference, password, gender, birthdate) {
    const axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    }
    const requestBody = {
      firstname: firstName,
      lastname: lastName,
      adress: adress,
      emailadress: email,
      preference: preference,
      password: password,
      gender: gender,
      dayOfBirth: birthdate
    }
    return Repository.post(`${recource}?${qs.stringify(requestBody)}`, qs.stringify(requestBody), axiosConfig)
  }
}
