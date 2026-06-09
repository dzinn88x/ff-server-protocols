using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001356 RID: 4950
	[Token(Token = "0x2001356")]
	public class TweenPositionArc : MonoBehaviour
	{
		// Token: 0x06004EAC RID: 20140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x1A34E00", Offset = "0x1A34E00", VA = "0x7BBC234E00")]
		private void Update()
		{
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x1A351F0", Offset = "0x1A351F0", VA = "0x7BBC2351F0")]
		private void SetFactor()
		{
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x1A35234", Offset = "0x1A35234", VA = "0x7BBC235234")]
		private void SetFactor(TweenPositionArc.Quadrant quadrant)
		{
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x1A35438", Offset = "0x1A35438", VA = "0x7BBC235438")]
		public void StartAnimation(Vector3 startPos, Vector3 endPos, float speed = 1f, TweenPositionArc.Quadrant quadrant = TweenPositionArc.Quadrant.None)
		{
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB0")]
		[Address(RVA = "0x1A35120", Offset = "0x1A35120", VA = "0x7BBC235120")]
		private void StopAnimation()
		{
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB1")]
		[Address(RVA = "0x1A35514", Offset = "0x1A35514", VA = "0x7BBC235514")]
		public TweenPositionArc()
		{
		}

		// Token: 0x040075D9 RID: 30169
		[Token(Token = "0x40075D9")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 mStartPos;

		// Token: 0x040075DA RID: 30170
		[Token(Token = "0x40075DA")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 mEndPos;

		// Token: 0x040075DB RID: 30171
		[Token(Token = "0x40075DB")]
		[FieldOffset(Offset = "0x30")]
		private float mF1;

		// Token: 0x040075DC RID: 30172
		[Token(Token = "0x40075DC")]
		[FieldOffset(Offset = "0x34")]
		private float mF2;

		// Token: 0x040075DD RID: 30173
		[Token(Token = "0x40075DD")]
		[FieldOffset(Offset = "0x38")]
		private float mTime;

		// Token: 0x040075DE RID: 30174
		[Token(Token = "0x40075DE")]
		[FieldOffset(Offset = "0x3C")]
		private float mSpeed;

		// Token: 0x040075DF RID: 30175
		[Token(Token = "0x40075DF")]
		[FieldOffset(Offset = "0x40")]
		private bool mPlay;

		// Token: 0x02001357 RID: 4951
		[Token(Token = "0x2001357")]
		public enum Quadrant
		{
			// Token: 0x040075E1 RID: 30177
			[Token(Token = "0x40075E1")]
			None,
			// Token: 0x040075E2 RID: 30178
			[Token(Token = "0x40075E2")]
			First,
			// Token: 0x040075E3 RID: 30179
			[Token(Token = "0x40075E3")]
			Second,
			// Token: 0x040075E4 RID: 30180
			[Token(Token = "0x40075E4")]
			Third,
			// Token: 0x040075E5 RID: 30181
			[Token(Token = "0x40075E5")]
			Fourth
		}
	}
}
