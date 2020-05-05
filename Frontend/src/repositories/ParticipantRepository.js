import Repository from './Repository'
const recource = '/Participants'

export default {
  UpdateParticipant (userId, postId) {
    const payload = userId + ',' + postId
    return Repository.put(`${recource}/${userId},${postId}`, payload)
  }
}
