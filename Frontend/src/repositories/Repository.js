import axios from 'axios'

const baseDomain = 'http://localhost:59119'
const baseURL = `${baseDomain}/api`

export default axios.create({
  baseURL
})
