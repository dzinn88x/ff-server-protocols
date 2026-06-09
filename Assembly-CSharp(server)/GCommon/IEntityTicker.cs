using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EF3 RID: 3827
	[Token(Token = "0x2000EF3")]
	internal interface IEntityTicker
	{
		// Token: 0x0600357B RID: 13691
		[Token(Token = "0x600357B")]
		void OnFixedUpdate(float gameTime, float deltaTime);

		// Token: 0x0600357C RID: 13692
		[Token(Token = "0x600357C")]
		void OnUpdate(float gameTime, float deltaTime);

		// Token: 0x0600357D RID: 13693
		[Token(Token = "0x600357D")]
		void OnPaused();

		// Token: 0x0600357E RID: 13694
		[Token(Token = "0x600357E")]
		void OnResumed();
	}
}
