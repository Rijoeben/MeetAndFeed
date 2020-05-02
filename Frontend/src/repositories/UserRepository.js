import Repository from './Repository'

const recource = '/User'
export default {
  checkCredentials (email, password) {
    const payload = email + ',' + password
    return Repository.get(`${recource}/${payload}`)
  }
}
