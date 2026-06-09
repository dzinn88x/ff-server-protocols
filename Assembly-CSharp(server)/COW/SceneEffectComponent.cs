using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012B9 RID: 4793
	[Token(Token = "0x20012B9")]
	public class SceneEffectComponent : MonoBehaviour
	{
		// Token: 0x06004B33 RID: 19251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x1B32DE0", Offset = "0x1B32DE0", VA = "0x7BBC332DE0")]
		private void Start()
		{
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x1B32DE4", Offset = "0x1B32DE4", VA = "0x7BBC332DE4")]
		public void BindEffectResource()
		{
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x1B33280", Offset = "0x1B33280", VA = "0x7BBC333280")]
		public SceneEffectComponent()
		{
		}

		// Token: 0x04007363 RID: 29539
		[Token(Token = "0x4007363")]
		[FieldOffset(Offset = "0x18")]
		public string StrEffectResName;

		// Token: 0x04007364 RID: 29540
		[Token(Token = "0x4007364")]
		[FieldOffset(Offset = "0x20")]
		public GameObject objEffectTarget;
	}
}
