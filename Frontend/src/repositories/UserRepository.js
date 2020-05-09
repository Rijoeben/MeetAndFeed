import Repository from './Repository'

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
  }
}
