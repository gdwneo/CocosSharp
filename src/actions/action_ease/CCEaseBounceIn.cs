namespace CocosSharp
{
	public class CCEaseBounceIn : CCActionEase
	{
		#region Constructors

        public CCEaseBounceIn (CCFiniteTimeAction pAction) : base (pAction)
		{
		}

		#endregion Constructors


		internal override CCActionState StartAction(CCNode target)
		{
			return new CCEaseBounceInState (this, target);
		}

		public override CCFiniteTimeAction Reverse ()
		{
            return new CCEaseBounceOut ((CCFiniteTimeAction)InnerAction.Reverse ());
		}
	}


	#region Action state

	internal class CCEaseBounceInState : CCActionEaseState
	{
		public CCEaseBounceInState (CCEaseBounceIn action, CCNode target) : base (action, target)
		{
		}

		public override void Update (float time)
		{
			InnerActionState.Update (CCEaseMath.BounceIn (time));
		}
	}

	#endregion Action state
}