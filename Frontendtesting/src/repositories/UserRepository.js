import Repository from './Repository'

const recource = '/User'
export default {
  checkCredentials (email, password) {
    const payload = email + ',' + password
    return Repository.get(`${recource}/${payload}`)
  },
  getId (email) {
    return Repository.get(`${recource}/SessionId?email=${email}`)
  },
  getUserById (userId) {
    return Repository.get(`${recource}/${userId}`)
  }
}
