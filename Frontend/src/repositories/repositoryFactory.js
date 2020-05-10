import PostRepository from './postsRepository'
import UserRepository from './UserRepository'
import ParticipantRepository from './ParticipantRepository'
import ReviewRepository from './ReviewRepository'

const repositories = {
  posts: PostRepository,
  user: UserRepository,
  participant: ParticipantRepository,
  review: ReviewRepository
}

export const RepositoryFactory = {
  get: name => repositories[name]
}
