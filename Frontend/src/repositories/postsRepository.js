import Repository from './Repository'

const recource = '/Post'
export default {
  getAllPosts () {
    return Repository.get(`${recource}`)
  },
  getPost (postId) {
    return Repository.get(`${recource}/${postId}`)
  }
}
