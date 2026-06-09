using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BFE RID: 7166
	[Token(Token = "0x2001BFE")]
	public class WeaponRackDragDropItem : UIDragDropItem
	{
		// Token: 0x06009BBB RID: 39867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BBB")]
		[Address(RVA = "0x179C840", Offset = "0x179C840", VA = "0x7BBBF9C840", Slot = "7")]
		protected override void Start()
		{
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BBC")]
		[Address(RVA = "0x179C868", Offset = "0x179C868", VA = "0x7BBBF9C868", Slot = "18")]
		protected override void OnDragDropStart()
		{
		}

		// Token: 0x06009BBD RID: 39869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BBD")]
		[Address(RVA = "0x179C930", Offset = "0x179C930", VA = "0x7BBBF9C930", Slot = "20")]
		protected override void OnDragDropRelease(GameObject surface)
		{
		}

		// Token: 0x06009BBE RID: 39870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BBE")]
		[Address(RVA = "0x179C938", Offset = "0x179C938", VA = "0x7BBBF9C938", Slot = "17")]
		public override void OnDragOverObject(GameObject go)
		{
		}

		// Token: 0x06009BBF RID: 39871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BBF")]
		[Address(RVA = "0x179CC94", Offset = "0x179CC94", VA = "0x7BBBF9CC94")]
		public void OnDragOut()
		{
		}

		// Token: 0x06009BC0 RID: 39872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC0")]
		[Address(RVA = "0x179CD30", Offset = "0x179CD30", VA = "0x7BBBF9CD30")]
		public void OnDragOverTrigger()
		{
		}

		// Token: 0x06009BC1 RID: 39873 RVA: 0x00028E48 File Offset: 0x00027048
		[Token(Token = "0x6009BC1")]
		[Address(RVA = "0x179CE14", Offset = "0x179CE14", VA = "0x7BBBF9CE14", Slot = "11")]
		public override bool StartDragging()
		{
			return default(bool);
		}

		// Token: 0x06009BC2 RID: 39874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC2")]
		[Address(RVA = "0x179CF98", Offset = "0x179CF98", VA = "0x7BBBF9CF98")]
		public WeaponRackDragDropItem()
		{
		}

		// Token: 0x0400A1EE RID: 41454
		[Token(Token = "0x400A1EE")]
		[FieldOffset(Offset = "0xB8")]
		public WeaponSkinBaseInfo DragDropBasicInfo;

		// Token: 0x0400A1EF RID: 41455
		[Token(Token = "0x400A1EF")]
		[FieldOffset(Offset = "0xC0")]
		public UILobbyWeaponSlotController m_Slot;
	}
}
