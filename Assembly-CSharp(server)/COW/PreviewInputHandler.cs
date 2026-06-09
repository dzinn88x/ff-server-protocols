using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW
{
	// Token: 0x0200128A RID: 4746
	[Token(Token = "0x200128A")]
	public class PreviewInputHandler : MonoBehaviour
	{
		// Token: 0x06004992 RID: 18834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004992")]
		[Address(RVA = "0x1748628", Offset = "0x1748628", VA = "0x7BBBF48628")]
		public void SetPreviewInputEnable(bool flag)
		{
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004993")]
		[Address(RVA = "0x1748634", Offset = "0x1748634", VA = "0x7BBBF48634")]
		private void Start()
		{
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004994")]
		[Address(RVA = "0x1748810", Offset = "0x1748810", VA = "0x7BBBF48810")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004995")]
		[Address(RVA = "0x1748A3C", Offset = "0x1748A3C", VA = "0x7BBBF48A3C")]
		private void FingerSet(LeanFinger finger)
		{
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004996")]
		[Address(RVA = "0x1748E44", Offset = "0x1748E44", VA = "0x7BBBF48E44")]
		private void FingerDown(LeanFinger finger)
		{
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x6004997")]
		[Address(RVA = "0x1748B18", Offset = "0x1748B18", VA = "0x7BBBF48B18")]
		public static bool IsOverGUIElements(Vector2 screenPosition)
		{
			return default(bool);
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004998")]
		[Address(RVA = "0x1748C08", Offset = "0x1748C08", VA = "0x7BBBF48C08")]
		private void RotateList(float angle, float angledelta = 0f)
		{
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004999")]
		[Address(RVA = "0x1748E84", Offset = "0x1748E84", VA = "0x7BBBF48E84")]
		private void Update()
		{
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499A")]
		[Address(RVA = "0x1748E88", Offset = "0x1748E88", VA = "0x7BBBF48E88")]
		public PreviewInputHandler()
		{
		}

		// Token: 0x0400726C RID: 29292
		[Token(Token = "0x400726C")]
		[FieldOffset(Offset = "0x18")]
		private float RotateSensitivity;

		// Token: 0x0400726D RID: 29293
		[Token(Token = "0x400726D")]
		[FieldOffset(Offset = "0x1C")]
		private float CurrentPanAngle;

		// Token: 0x0400726E RID: 29294
		[Token(Token = "0x400726E")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 lastTouchPos;

		// Token: 0x0400726F RID: 29295
		[Token(Token = "0x400726F")]
		[FieldOffset(Offset = "0x28")]
		private bool InputEnable;

		// Token: 0x04007270 RID: 29296
		[Token(Token = "0x4007270")]
		[FieldOffset(Offset = "0x30")]
		public List<GameObject> m_PreviewTransList;

		// Token: 0x0200128B RID: 4747
		[Token(Token = "0x200128B")]
		private enum MouseButton
		{
			// Token: 0x04007272 RID: 29298
			[Token(Token = "0x4007272")]
			Left,
			// Token: 0x04007273 RID: 29299
			[Token(Token = "0x4007273")]
			Right,
			// Token: 0x04007274 RID: 29300
			[Token(Token = "0x4007274")]
			Middle,
			// Token: 0x04007275 RID: 29301
			[Token(Token = "0x4007275")]
			None
		}
	}
}
