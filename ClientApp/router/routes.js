import HomePage from 'components/about-page'
import GalleryPage from 'components/gallery-page'
import NewsletterPage from 'components/newsletter-page'
import AdminPage from 'components/admin-page'

export const routes = [
  { name: 'about', path: '/', component: HomePage, display: 'About', icon: 'home' },
  { name: 'gallery', path: '/gallery', component: GalleryPage, display: 'Gallery', icon: 'home' },
  { name: 'newsletter', path: '/newsletter', component: NewsletterPage, display: 'Newsletter', icon: 'home' },
  { name: 'admin', path: '/admin', component: AdminPage, display: 'Admin', icon: 'home' },
]
