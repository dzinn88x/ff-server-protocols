using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012BA RID: 4794
	[Token(Token = "0x20012BA")]
	public class SceneObjectDynamicLoader : MonoBehaviour
	{
		// Token: 0x06004B36 RID: 19254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x1B332D8", Offset = "0x1B332D8", VA = "0x7BBC3332D8")]
		private void Start()
		{
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x1B33314", Offset = "0x1B33314", VA = "0x7BBC333314")]
		private void LoadResource(string resourIDStr)
		{
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x1B33648", Offset = "0x1B33648", VA = "0x7BBC333648")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x1B336F4", Offset = "0x1B336F4", VA = "0x7BBC3336F4")]
		public SceneObjectDynamicLoader()
		{
		}

		// Token: 0x04007365 RID: 29541
		[Token(Token = "0x4007365")]
		[FieldOffset(Offset = "0x18")]
		public string m_resourceID;

		// Token: 0x04007366 RID: 29542
		[Token(Token = "0x4007366")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_gameObject;
	}
}
