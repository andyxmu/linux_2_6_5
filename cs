#!/bin/bash
find ./net/bridge/ -iregex '.*\.[ch]' > cscope.files
find ./net/ethernet/ -iregex '.*\.[ch]' >> cscope.files
find ./net/core/ -iregex '.*\.[ch]' >> cscope.files
find ./net/ipv4/ -iregex '.*\.[ch]' >> cscope.files
find ./net/ipv6/ -iregex '.*\.[ch]' >> cscope.files
find ./net/netfilter/ -iregex '.*\.[ch]' >> cscope.files
find ./net/packet/ -iregex '.*\.[ch]' >> cscope.files
find ./net/packet.c  >> cscope.files
find ./kernel/ -iregex '.*\.[ch]' >> cscope.files
find ./init/ -iregex '.*\.[ch]' >> cscope.files
find ./include/net/ -iregex '.*\.[ch]' >> cscope.files
find ./include/linux/ -iregex '.*\.[ch]' >> cscope.files
find ./arch/x86/kernel -iregex '.*\.[ch]' >> cscope.files
find ./drivers/net/igb/ -iregex '.*\.[ch]' >> cscope.files

echo "---------Files assemble done!----------"
cscope -Rbk -i cscope.files

