import PostRepository from './postsRepository'
import UserRepository from './UserRepository'
import ParticipantRepository from './ParticipantRepository'

const repositories = {
  posts: PostRepository,
  user: UserRepository,
  participant: ParticipantRepository
}

export const RepositoryFactory = {
  get: name => repositories[name]
}
