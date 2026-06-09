using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001451 RID: 5201
	[Token(Token = "0x2001451")]
	public class UIAvatarStateTriggerValue<T> where T : struct
	{
		// Token: 0x06005739 RID: 22329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005739")]
		public void Set(T t)
		{
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573A")]
		public T GetAndReset()
		{
			return null;
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573B")]
		public void CloneTo(UIAvatarStateTriggerValue<T> s)
		{
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573C")]
		public UIAvatarStateTriggerValue()
		{
		}

		// Token: 0x04007B82 RID: 31618
		[Token(Token = "0x4007B82")]
		[FieldOffset(Offset = "0x0")]
		private T m_value;
	}
}
