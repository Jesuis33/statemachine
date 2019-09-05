//-------------------------------------------------------------------------------
// <copyright file="ITransition.cs" company="Appccelerate">
//   Copyright (c) 2008-2017 Appccelerate
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.StateMachine.Machine
{
    using System;
    using Transitions;

    /// <summary>
    /// Represents a transition in the state machine.
    /// </summary>
    /// <typeparam name="TState">The type of the state.</typeparam>
    /// <typeparam name="TEvent">The type of the event.</typeparam>
    public interface ITransitionLogic<TState, TEvent>
        where TState : IComparable
        where TEvent : IComparable
    {
        /// <summary>
        /// Fires the transition.
        /// </summary>
        /// <param name="transitionDefinition">The definition of the transition which should happen.</param>
        /// <param name="context">The event context.</param>
        /// <returns>The result of the transition.</returns>
        /// <param name="lastActiveStateModifier">The last active state modifier.</param>
        ITransitionResult<TState> Fire(
            ITransitionDefinition<TState, TEvent> transitionDefinition,
            ITransitionContext<TState, TEvent> context,
            ILastActiveStateModifier<TState, TEvent> lastActiveStateModifier);
    }
}