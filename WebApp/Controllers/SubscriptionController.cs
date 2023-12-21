﻿using AutoMapper;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly IMapper _mapper;

        public SubscriptionController(ISubscriptionRepository subscriptionRepository, IMapper mapper)
        {
            _subscriptionRepository = subscriptionRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAll()
        {
            var result = _subscriptionRepository.GetAllSubscriptions();
            var subscriptions = _mapper.Map<IEnumerable<Subscription>>(result);

            return View("SubscriptionsList", subscriptions);
        }
    }
}
