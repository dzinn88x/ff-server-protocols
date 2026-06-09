using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ED1 RID: 3793
	[Token(Token = "0x2000ED1")]
	public abstract class SingletonModule<T> : ISingletonModule where T : SingletonModule<!0>, new()
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000691")]
		public static T instance
		{
			[Token(Token = "0x6003464")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003465")]
		public SingletonModule()
		{
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003466")]
		public void Init()
		{
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003467")]
		public void Cleanup()
		{
		}

		// Token: 0x06003468 RID: 13416
		[Token(Token = "0x6003468")]
		protected abstract void OnInit();

		// Token: 0x06003469 RID: 13417
		[Token(Token = "0x6003469")]
		protected abstract void OnCleanup();

		// Token: 0x0600346A RID: 13418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346A")]
		public void UnLoadMemoryIfNecessary()
		{
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346B")]
		public void ReloadMemoryIfNecessary()
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346C")]
		protected virtual void OnUnloadMemeory()
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346D")]
		protected virtual void OnReloadMemory()
		{
		}

		// Token: 0x0400480F RID: 18447
		[Token(Token = "0x400480F")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		// Token: 0x04004810 RID: 18448
		[Token(Token = "0x4004810")]
		[FieldOffset(Offset = "0x0")]
		private bool m_HasInited;

		// Token: 0x04004811 RID: 18449
		[Token(Token = "0x4004811")]
		[FieldOffset(Offset = "0x0")]
		private bool m_HasUnloadPartialMemory;
	}
}
