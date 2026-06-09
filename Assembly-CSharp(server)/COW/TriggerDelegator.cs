using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001276 RID: 4726
	[Token(Token = "0x2001276")]
	public class TriggerDelegator : MonoBehaviour
	{
		// Token: 0x06004924 RID: 18724 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x6004924")]
		[Address(RVA = "0x1A32420", Offset = "0x1A32420", VA = "0x7BBC232420", Slot = "4")]
		protected virtual bool CheckCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x1A3248C", Offset = "0x1A3248C", VA = "0x7BBC23248C")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x1A324D8", Offset = "0x1A324D8", VA = "0x7BBC2324D8")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x1A32524", Offset = "0x1A32524", VA = "0x7BBC232524", Slot = "5")]
		protected virtual void OnEnterTriggerChecked(Collider other)
		{
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004928")]
		[Address(RVA = "0x1A3260C", Offset = "0x1A3260C", VA = "0x7BBC23260C", Slot = "6")]
		protected virtual void OnExitTriggerChecked(Collider other)
		{
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x1A326F8", Offset = "0x1A326F8", VA = "0x7BBC2326F8")]
		public TriggerDelegator()
		{
		}

		// Token: 0x04007214 RID: 29204
		[Token(Token = "0x4007214")]
		[FieldOffset(Offset = "0x18")]
		public IOnTriggerEnterExit TriggerEnterTarget;

		// Token: 0x04007215 RID: 29205
		[Token(Token = "0x4007215")]
		[FieldOffset(Offset = "0x20")]
		public Action<Collider> OnEnter;

		// Token: 0x04007216 RID: 29206
		[Token(Token = "0x4007216")]
		[FieldOffset(Offset = "0x28")]
		public Action<Collider> OnExit;
	}
}
